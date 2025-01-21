﻿using Microsoft.AspNetCore.Identity.Data;

namespace IdentityServer.DTOs
{
    public class LoginRequestDTO
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }

    }
}
