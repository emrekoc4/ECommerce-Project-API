using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectECommerce.Core.DTOs;
using ProjectECommerce.Core.Models;
using ProjectECommerce.Core.Services;
using ProjectECommerce.API.Filters;
using ProjectECommerce.Message.Service;

namespace ProjectECommerce.API.Controllers
{
    [ValidateFilterAttribute]
    public class OrdersController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Order> _orderService;
        private readonly IService<Product> _productService;
        private readonly IService<OrderDetail> _orderDetailService;
        private readonly IPublisherService _publisher;

        public OrdersController(IMapper mapper, IService<Order> orderService, IService<OrderDetail> orderDetailService, IService<Product> productService, IPublisherService publisher)
        {
            _mapper = mapper;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _productService = productService;
            _publisher = publisher;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderRequestDto createOrderRequestDto)
        {
            var order = _mapper.Map<Order>(createOrderRequestDto);
            List<OrderDetail> orderDetailsList = new List<OrderDetail>();
            foreach (var item in createOrderRequestDto.ProductDetailDtos)
            {
                order.TotalAmount += item.Amount * _productService.GetByIdAsync(item.Id).Result.UnitPrice;
            }
            var addedOrder = await _orderService.AddAsync(order);
            foreach(var item in createOrderRequestDto.ProductDetailDtos)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderId = addedOrder.Id;
                orderDetail.ProductId = item.Id;
                orderDetail.UnitPrice = _productService.GetByIdAsync(item.Id).Result.UnitPrice * item.Amount;
                _orderDetailService.AddAsync(orderDetail);
            }
            await _publisher.PublishAsync(addedOrder.Id, addedOrder.CustomerEMail); //email sending

            return CreateActionResult(CustomResponseDto<Order>.Success(200, addedOrder.Id));
        }
    }
}
