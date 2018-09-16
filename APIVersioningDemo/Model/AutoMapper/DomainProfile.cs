using APIVersioningDemo.Model;
using APIVersioningDemo.Model.Response;
using AutoMapper;

public class DomainProfile : Profile
{
    public DomainProfile()
    {
        CreateMap<Information, InfoModel>();
        CreateMap<Information, GenderModal>();
        CreateMap<Information, ContactInfo>();
    }
}