select * from pedidoxmesa where estado=1 order by numeromesa asc

select * from pedidoxmesa where estado=0

select * from mozoxmesa

select * from numeromesa

delete numeromesa where numero=1

delete pedidoxmesa where estado=1

insert into numeromesa (numero) values (1)
select numeromesa,estado,mozoasignado,numeropedido from pedidoxmesa where estado=0 or estado=1