using Shop_Kilunina.Data.Interfaces;
using Shop_Kilunina.Data.Models;
using System.Collections.Generic;

namespace Shop_Kilunina.Data.Mocks
{
    public class MockCaregorys : ICategorys
    {
        public IEnumerable<Categories> AllCategorys
        {
            get
            {
                return new List<Categories>
                {
                    new Categories() {
                        Id = 0,
                        Name = "Микроволновые печи",
                        Description = "Микроволновая печь — электроприбор, позволяющий быстро разогревать и готовить пищу с помощью электромагнитного излучения."
                    },
                    new Categories() {
                        Id = 1,
                        Name = "Мультиварки",
                        Description = "Мультиварка — многофункциональный бытовой прибор для приготовления разнообразных блюд в автоматическом режиме."
                    },
                    new Categories() {
                        Id = 2,
                        Name = "Кофемашины",
                        Description = "Кофемашина — устройство для автоматического приготовления кофе: эспрессо, капучино и других популярных напитков."
                    },
                };
            }
        }
    }
}
