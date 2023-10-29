using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var Context = new Context())
            {
                return Context.Reservations.Include(x => x.Destination).Where(x => x.status == "Onaylandı"
                    && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var Context = new Context())
            {
                return Context.Reservations.Include(x => x.Destination).Where(x => x.status == "Geçmiş Rezervasyon"
                    && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using(var Context = new Context())
            {
                return Context.Reservations.Include(x=>x.Destination).Where(x=>x.status == "Onay Bekliyor"
                    && x.AppUserId == id).ToList();
            }
        }
    }
}
