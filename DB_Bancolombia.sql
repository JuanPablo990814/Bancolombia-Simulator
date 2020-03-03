create database DB_Bancolombia
use DB_Bancolombia

create table tblClientes
(ced bigint not null,
nombre varchar(50) not null,
telefono bigint not null,
direccion varchar(50) not null,
primary key(ced)
)

insert into tblClientes  values(99081404301,'Laura Roy','12314','manzana2')



select*
from tblClientes
where ced = 99081404301

delete
from tblClientes
where ced= 69081404304

update tblClientes
set nombre ='Paulina Vega',telefono=12345 ,direccion ='manzana30'
where ced = 79081404303


create procedure sp_ModificarCliente
@ced bigint,
@nom varchar(50),
@tel bigint,
@direcc varchar(50)
as update tblClientes
set nombre = @nom , telefono = @tel, direccion = @direcc
where ced = @ced

exec sp_ModificarCliente 99081404301,'Arturito Rodriguez',19283,'manzana50'

create table tblAsesores
(iduser int identity(1,1),
usuario varchar(30) unique,
contraseña varchar(30) not null,
primary key (iduser)
)

insert into tblAsesores values('juan','2k16')
insert into tblAsesores values('ramon123','chilindrina')
insert into tblAsesores values('bigben','12:00')
insert into tblAsesores values('L','123')
insert into tblAsesores values('D','123')
insert into tblAsesores values('Juan123','123')
insert into tblAsesores values('juancho321','123')

create procedure sp_VerificarAsesor
@user varchar(30),
@clave varchar(30)
as
select*
from tblAsesores
where usuario = @user and 
contraseña = @clave

exec sp_VerificarAsesor 'juancho321','123'


create table tblInfoCliente
(ced bigint not null,
 ingresos bigint not null,
 egresos bigint not null,
 deudas bigint not null,
 score int not null,check (score between 0 and 800),
foreign key(ced)references tblClientes(ced),
primary key(ced))

insert into tblInfoCliente values(99081404301,1000,600,0,500)
insert into tblInfoCliente values(69081404304,1000,600,0,500)

select*
from tblInfoCliente
inner join tblClientes
on tblInfoCliente.ced = tblClientes.ced


create procedure sp_InfoCliente
@ced bigint
as
select tblInfoCliente.ced,tblClientes.nombre,tblInfoCliente.ingresos,tblInfoCliente.egresos,tblInfoCliente.deudas,tblInfoCliente.score
from tblInfoCliente
inner join tblClientes
on tblInfoCliente.ced = tblClientes.ced
where @ced = tblInfoCliente.ced

exec sp_InfoCliente 99081404301

create table tblProductos
(num_cuenta int identity(1,1),
nombre_producto varchar(30),check (nombre_producto in('MasterCard','MasterCard Gold','Maestro')),
tipo_producto varchar(30),check (tipo_producto in('Ahorros','Credito')),
deuda bigint not null,
cedula bigint not null,
primary key (cedula),
foreign key (cedula)references tblClientes(ced)
)

insert into tblProductos  values('MasterCard','Ahorros',0,99081404301)
insert into tblProductos  values('MasterCard Gold','Credito',0,99081404301)
insert into tblProductos  values('Maestro','Ahorros',0,99081404301)


select*
from tblProductos where cedula = 99081404301

alter procedure sp_ConsultaPrestamo
@ced bigint
as
select tblClientes.ced as Cedula,tblClientes.nombre as Nombre,tblInfoCliente.ingresos as Ingresos,tblInfoCliente.egresos as Egresos,tblInfoCliente.score as Score,tblProductos.num_cuenta as #Cuenta,tblProductos.nombre_producto as Nombre_de_producto,tblProductos.tipo_producto as Tipo_de_producto,tblProductos.deuda as Deuda
from tblClientes
inner join tblInfoCliente
on tblInfoCliente.ced = tblClientes.ced
inner join tblProductos
on tblClientes.ced = tblProductos.cedula
where tblClientes.ced = @ced and @ced = tblClientes.ced
order by tblClientes.nombre

exec sp_ConsultaPrestamo 333333


create table tblPrestamo
(cod_prestamo int identity(1,1),
cedula bigint not null,
val_prestamo bigint not null,
num_cuotas int not null,
tipo_prestamo varchar(30),
primary key(cod_prestamo),
foreign key(cedula)references tblClientes(ced)
)

insert into tblPrestamo values(99081404301,1000,12,'Vehiculo')
insert into tblPrestamo values(99081404301,1000,12,'Vivienda')
insert into tblPrestamo values(99081404301,1000,12,'Vehiculo')
insert into tblPrestamo values(99081404301,1000,12,'Vehiculo')


create procedure sp_ConsultaPrestamoPrueba 

@ced bigint
as
select tblClientes.ced as Cedula,tblClientes.nombre as Nombre,tblInfoCliente.ingresos as Ingresos,tblInfoCliente.egresos as Egresos,tblInfoCliente.score as Score,tblProductos.num_cuenta as #Cuenta,tblProductos.nombre_producto as Nombre_de_producto,tblProductos.tipo_producto as Tipo_de_producto,tblProductos.deuda as Deuda,sum(tblProductos.deuda) as Deuda_total
from tblClientes
inner join tblInfoCliente
on tblInfoCliente.ced = tblClientes.ced
inner join tblProductos
on tblClientes.ced = tblProductos.cedula
where tblClientes.ced = @ced and @ced = tblClientes.ced
group by tblProductos.cedula

create trigger Tr_ActualizarDeudas
on tblPrestamo
for insert
as update tblInfoCliente
set tblInfoCliente.deudas = tblInfoCliente.deudas+1
from tblInfoCliente inner join inserted
on tblInfoCliente.ced = inserted.cedula

create trigger Tr_ActualizarDeuda
on tblPrestamo
for insert
as update tblProductos
set tblProductos.deuda = tblProductos.deuda + inserted.val_prestamo
from tblProductos inner join inserted
on tblProductos.cedula = inserted.cedula

exec sp_ConsultarTotalDeudas 43109401

/* No sirve
create procedure sp_ConsultarTotalDeudas
@ced bigint
as
select sum(tblPrestamo.val_prestamo) as Total_Deudas
from tblPrestamo
where cedula = @ced and @ced = cedula

exec sp_ConsultarTotalDeudas 43109401
*/

select Deuda
from tblProductos
where cedula = 333333

create trigger Tr_ActualizarBorrarDeudas
on tblPrestamo
for delete
as update tblInfoCliente
set tblInfoCliente.deudas = tblInfoCliente.deudas-1
from tblInfoCliente inner join deleted
on tblInfoCliente.ced = deleted.cedula

create trigger Tr_ActualizarBorrarDeuda
on tblPrestamo
for delete
as update tblProductos
set tblProductos.deuda = tblProductos.deuda - deleted.val_prestamo
from tblProductos inner join deleted
on tblProductos.cedula = deleted.cedula



