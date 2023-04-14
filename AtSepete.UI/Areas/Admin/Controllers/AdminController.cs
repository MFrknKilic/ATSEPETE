﻿using AtSepete.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AtSepete.UI.Areas.Admin.Controllers
{
    //adminin kendiyle ilgili işlemlerini yönettiğimiz controller
    public class AdminController : AdminBaseController
    {
        public async Task<IActionResult> AdminDetail(Guid id)
        {
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:7286/AtSepeteApi/user/GetByIdUser/{id}"))
                {
                string apiResponse = await response.Content.ReadAsStringAsync();
                UserApiResponse user = JsonConvert.DeserializeObject<UserApiResponse>(apiResponse);
                return View(user);
                } ;
            };
        }
        [HttpGet]
        public async Task<IActionResult> AdminUpdate()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> AdminUpdate()
        //{
        //    return View();
        //}
    }
}