using revanth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revanth.rep
{
    public interface IReservation
    {
        List<ReservationModel> GetAllPassengers();
        string insertpassengers(ReservationModel rm);
        string updatepassengers(ReservationModel rs);
        string deletepassengers(int Id);
    }
    public class Res:IReservation
    {
        RegisterEntities3 obj = new RegisterEntities3();

        List<ReservationModel> IReservation.GetAllPassengers()
        {
            var list = obj.Reservations.Select(a => new ReservationModel()
            {
                Id=a.Id,
                Hotel=a.Hotel,
                Arrival=a.Arrival,
                Departure=a.Departure,
                Type=a.Type,
                Guests=a.Guests,
                Price=a.Price,
            }).ToList<ReservationModel>();
            return list;
        }

        string IReservation.insertpassengers(ReservationModel rm)
        {
            var pass = obj.Reservations.Where(w => w.Id == rm.Id).FirstOrDefault();
            if (pass==null)
            {
                obj.Reservations.Add(new Reservation()
                {
                    Id=rm.Id,
                    Hotel=rm.Hotel,
                    Arrival=rm.Arrival,
                    Departure=rm.Departure,
                    Type=rm.Type,
                    Guests = rm.Guests,
                    Price = rm.Price,
                });
            }
            obj.SaveChanges();
            obj.Dispose();
            return "passenger inserted";
        }
        string IReservation.updatepassengers(ReservationModel rs)
        {
            var nun = obj.Reservations.Where(w => w.Id == rs.Id).FirstOrDefault();
            if(nun!=null)
            {
                nun.Id = rs.Id;
                nun.Hotel = rs.Hotel;
                nun.Arrival = rs.Arrival;
                nun.Departure = rs.Departure;
                nun.Type = rs.Type;
                nun.Guests = rs.Guests;
                nun.Price = rs.Price;
            }
            obj.SaveChanges();
            obj.Dispose();
            return "passenger updated";
        }
        string IReservation.deletepassengers(int Id)
        {
            var non = obj.Reservations.Where(w => w.Id == Id).FirstOrDefault();
            if (non != null)
            {
                obj.Reservations.Remove(non);
            }
            obj.SaveChanges();
            obj.Dispose();
            return "passenger deleted";
        }
    }
}
