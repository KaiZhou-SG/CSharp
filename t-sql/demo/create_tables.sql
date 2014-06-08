CREATE TABLE dbo.Vehicle(
  ID int not null,
  VehicleType int not null,
  MaxLoad decimal,
  IsAvailable bit,

  CONSTRAINT pk_vehicle PRIMARY KEY (ID)
)
GO

CREATE TABLE dbo.Driver (
  ID int not null,
  Name varchar(23) not null,
  IsAvailable bit not null,
  DefaultVehicleID int,

  CONSTRAINT pk_driver  PRIMARY KEY (ID),
  CONSTRAINT fk_driver_vehicle FOREIGN KEY (DefaultVehicleID) REFERENCES [Vehicle]([ID])
)
GO

CREATE TABLE dbo.DriverAvailability(
  PlanDate Datetime not null,
  DriverID int not null,
  DriverAvailable bit not null,
  CONSTRAINT pk_driverAvailability PRIMARY KEY (PlanDate),
  CONSTRAINT fk_driverAvailabilityDriver FOREIGN KEY (DriverID) REFERENCES dbo.Driver([ID])
)
GO

CREATE TABLE dbo.VehicleAvailability(
  PlanDate Datetime not null,
  DriverID int not null,
  DriverAvailable bit not null,
  CONSTRAINT pk_vehicleAvailability PRIMARY KEY (PlanDate),
)
GO