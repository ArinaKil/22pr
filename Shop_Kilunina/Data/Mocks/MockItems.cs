using Shop_Kilunina.Data.Interfaces;
using Shop_Kilunina.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop_Kilunina.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategorys _category = new MockCaregorys();

        public IEnumerable<Items> AllItems
        {
            get
            {
                return new List<Items>()
                {
                    new Items() {
                        Id = 0,
                        Name = "DEXP MB-70",
                        Description = "Микроволновая печь DEXP MB-70 представлена в лаконичном черном корпусе с навесной дверцей и кнопкой. Модель с внутренним объемом 20 л оснащена поворотным столом с диаметром 25.5 см. Эмалированные стенки облегчают очистку от остатков пищи и запахов еды.",
                        Img = "https://c.dns-shop.ru/thumb/st4/fit/500/500/8632723b1befd4d685eff221552f2dd0/ca67c28e665850249f587a8b32ed2b21fb23fd80af1571cd49469273c1b0d138.jpg.webp",
                        Price = 3799,
                        Category = _category.AllCategories.Where(x => x.Id == 0).First()
                    },
                    new Items() {
                        Id = 1,
                        Name = "DEXP ES-70",
                        Description = "Микроволновая печь DEXP ES-70 представлена в белом корпусе с дисплеем и сенсорными кнопками. Вы можете блокировать управление от любопытных детей. Поворотный стол гарантирует равномерный прогрев продуктов и блюд. Камера на 20 л с диаметром поддона 25.5 см вмещает объемную посуду.",
                        Img = "https://c.dns-shop.ru/thumb/st4/fit/500/500/988026b016ec56e2fd890b4a1545b017/74fcd7425bfbba9b47d84fb84aa2f8fe96a52d8a580ae722dc1d4a8c29a023f1.jpg.webp",
                        Price = 4599,
                        Category = _category.AllCategories.Where(x => x.Id == 0).First()
                    },
                    new Items() {
                        Id = 2,
                        Name = "Redmond RMC-P350",
                        Description = "Мультиварка-скороварка Redmond RMC-P350 - настоящая помощника любой хозяйки, которая позволит вам освоить приготовление разнообразных блюд и побаловать ими всю вашу семью. Представленную модель отличает богатый функционал, который приятно удивит даже самого требовательного пользователя. Устройство с мощностью 900 Вт укомплектовано чашей с объемом 5 л. Благодаря антипригарному покрытию к ее стенкам и дну не пристает еда в процессе ее готовки. Настройка параметров работы мультиварки осуществляется при помощи сенсорной панели управления и поворотного механизма. Благодаря небольшому дисплею вы всегда будете знать о выбранной программе и оставшемся времени готовки.",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/4ad548fb18ac703c848a02977c37c1c1/c9813207d7790db07894a7dc9908b996f73266eda457c1569dc9c03cb9cd8f0d.jpg.webp",
                        Price = 10999,
                        Category = _category.AllCategories.Where(x => x.Id == 1).First()
                    },
                    new Items() {
                        Id = 3,
                        Name = "DEXP PC-100",
                        Description = "Мультиварка-скороварка DEXP PC-100 позволяет готовить различные блюда быстро и качественно. Она оборудована мощным нагревательным элементом, системой с 3-мя уровнями давления и алюминиевой чашей емкостью 5.7 л с долговечным антипригарным покрытием. В данной модели реализованы 15 автоматических программ и кнопочная панель управления с цифровым дисплеем.",
                        Img = "https://c.dns-shop.ru/thumb/st4/fit/500/500/d83664dab2fd1bb87fd172e91cc905bd/73109affc8f3953730ad24cc54bd57b358a62bfb712109a7836ee90d73768fe1.jpg.webp",
                        Price = 4399,
                        Category = _category.AllCategories.Where(x => x.Id == 1).First()
                    },
                    new Items() {
                        Id = 4,
                        Name = "DeLonghi Autentica Cappuccino ETAM 29.660.SB",
                        Description = "Автоматическая кофемашина DeLonghi ETAM 29.660.SB отличается компактными габаритами, благодаря чему она не займет много места на кухне. Модель управляется с помощью сенсорного дисплея, позволяющего выполнить персональные настройки и сохранить их в памяти устройства. Кофемашина проста в использовании и уходе.",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/11e912f5ef6b01e1b76f8418b14c6816/507d4431316521ec129577da09d3e6439ee149db4f8d79854dece76726c1de5a.jpg.webp",
                        Price = 43999,
                        Category = _category.AllCategories.Where(x => x.Id == 2).First()
                    },
                };
            }
        }
    }
}
