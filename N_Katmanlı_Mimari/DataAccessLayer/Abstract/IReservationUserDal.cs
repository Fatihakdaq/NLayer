using Core.Abstract;
using EntityLayer.Concrete;


namespace DataAccessLayer.Abstract
{
    public interface IReservationUserDal : IRepositoryBase<ReservationUser>
    {
        // IRepository Sınıfın tüm özelikleri buraya dahil ediyoruz 
    }
}
