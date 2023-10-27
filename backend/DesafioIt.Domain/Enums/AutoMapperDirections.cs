using System;
namespace DesafioIt.Domain.Enums
{
    public enum AutoMapperDirections
    {
        To = 0,
        From = 1,
        Both = 2
    }

    public enum DishType
    {
        Starters = 0,
        MainCourseDishes = 1,
        Desserts = 2,
        Beverages = 3
    }

    public enum OrderStatus
    {
        Pending = 0,
        Received = 1,
        Preparing = 2,
        Ready = 3,
        Cancelled = 4
    }

}

