﻿using AtSepete.Business.Abstract;
using AtSepete.Dtos.Dto.Shop;
using AtSepete.Dtos.Dto.Users;
using AtSepete.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtSepete.Api.Controllers
{
    [Route("AtSepeteApi/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {

        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {

            _shopService = shopService;
        }
        [HttpGet]
        [Route("[action]")]
        [Authorize(AuthenticationSchemes = "Customer")]
        public async Task<IDataResult<List<ShopListDto>>> ShopList()
        {
            return await _shopService.ShopListAsync();
        }
    }
}
