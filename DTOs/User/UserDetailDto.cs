﻿namespace BisleriumBloggers.DTOs.User;

public class UserDetailDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int RoleId { get; set; }

    public string RoleName { get; set; }

    public string Username { get; set; }

    public string EmailAddress { get; set; }

    public string ImageURL { get; set; }
}
