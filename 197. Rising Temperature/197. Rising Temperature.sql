

select w1.id from Weather as w1 join Weather as w2 on DATEDIFF(DAY, w2.recordDate, w1.recordDate) = 1 where w1.temperature > w2.temperature;
