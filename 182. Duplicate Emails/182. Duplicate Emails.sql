
select p.email as Email FROM person as p group by email having COUNT(p.email) > 1;