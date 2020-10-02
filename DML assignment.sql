use Dxc

SELECT Client_ID,Client_Name,Contact_Person,Agreement_Date from Client

-- insrt values in client table
insert into Client VALUES('Mohit','3434545','2020-02-02')

-- insert row without value for agreement date which can be null
insert into Client VALUES('Client 5','Queen')
-- not possible bcz column date value not supplied 

select * from Client


-- update command
update client set Contact_Person = 'Raja' where client_id = 2;

update Client set Agreement_Date = '2020-05-05' where client_id = 2;


-- deleting rows from table
delete from Client where client_id = 2; 