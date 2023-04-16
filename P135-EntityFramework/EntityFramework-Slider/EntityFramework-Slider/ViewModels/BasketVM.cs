using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class BasketVM
    {
        public Product Product { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
