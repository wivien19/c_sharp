CREATE TABLE Products(
 ID integer not null PRIMARY key AUTOINCREMENT,
 Name text not null,
 Manufacturer text not null,
 Price integer not null,
 Multiplier integer not null,
 BFPrice integer not null,
 UNIQUE(Name)
);
