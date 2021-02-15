﻿using OnlineShop.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface ISmsService
    {
        Task<SmsServiceResponseDTO> SendVerificationCode(string phoneNumber/*, string code*/);
    }
}
