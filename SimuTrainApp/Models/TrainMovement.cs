using System;
using System.Linq;
using SimuTrainApp.Data;
using Microsoft.EntityFrameworkCore;



public class TrainMovement
{
    private SimuTrainAppContext _context;

    public TrainMovement(SimuTrainAppContext context)
    {
        _context = context;
    }

    public void Move(int trainId, int departureStationId, int arrivalStationId)
    {
        var train = _context.Train.Include(x => x.RouteOfTrain)
                                   .FirstOrDefault(x => x.Id == trainId);
        if (train == null)
            throw new Exception("Invalid train id");

        var route = _context.Route.FirstOrDefault(x => x.DepartureStationId == departureStationId &&
                                                        x.ArrivalStationId == arrivalStationId);
        if (route == null)
            throw new Exception("Invalid route");

        train.RouteOfTrain = route;
        train.CurrentStationId = departureStationId;

        _context.SaveChanges();
    }
}
