using AutoMapper;
using PiData.Domain;
using PiDataApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDataApp.Infrastructure
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();


        }



        public static void Run()
        {
            Mapper.Initialize(a =>
            {
                a.AddProfile<AutoMapperProfile>();
            });
        }
    }
}