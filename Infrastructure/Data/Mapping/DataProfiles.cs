using AutoMapper;
using Core.Domain.Entity;
using Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Mapping
{
    public class DataProfiles : Profile
    {

        public DataProfiles()
        {

            CreateMap<User, ApplicationUser>().ConstructUsing(u => new ApplicationUser {Id=u.Id, Email=u.Email, EmailConfirmed=u.EmailConfirmed, Name= u.Name, NormalizedEmail=u.NormalizedEmail, NormalizedUserName=u.NormalizedUserName, PasswordHash=u.PasswordHash,PhoneNumber=u.PhoneNumber, PhoneNumberConfirmed=u.PhoneNumberConfirmed,TwoFactorEnabled=u.TwoFactorEnabled,  UserName=u.UserName});
            CreateMap<ApplicationUser, User>().ConstructUsing(au => new User(au.Name, au.UserName, au.NormalizedUserName, au.Email, au.EmailConfirmed, au.PhoneNumber,au.PhoneNumberConfirmed,au.TwoFactorEnabled,0,null));
        }
    }
}
