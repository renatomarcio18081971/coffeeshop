using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLProject.Services
{
    public class ReservationService : IReservation
    {

        private GraphQLDbContext _dbcontext;

        public ReservationService(GraphQLDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Reservation AddReservation(Reservation reservation)
        {
            _dbcontext.Reservation.Add(reservation);
            _dbcontext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _dbcontext.Reservation.ToList();
        }
    }
}
