using AutoMapper;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, DtoCity>().ReverseMap();
            CreateMap<CreditCard, DtoCreditCard>().ReverseMap();
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();
            CreateMap<OrderStatus, DtoOrderStatus>().ReverseMap();
            CreateMap<PaymentType, DtoPaymentType>().ReverseMap();
            CreateMap<Policy, DtoPolicy>().ReverseMap();
            CreateMap<Region, DtoRegion>().ReverseMap();
            CreateMap<Application, DtoApplication>().ReverseMap();
            CreateMap<OrdersCustomer, DtoOrdersCustomer>().ReverseMap();
        }
    }
}
