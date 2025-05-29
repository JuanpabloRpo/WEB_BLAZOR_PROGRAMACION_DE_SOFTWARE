﻿using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces
{
    public interface IUserService
    {/*
        Task<List<User>> ListUsers();*/
        Task<User> GetUser(int userId);
        Task<Boolean> CreateUser(User user);/*
        Task<Boolean> UpdateUser(User user);
        Task<Boolean> DeleteUser(int userId);*/
    }
}
