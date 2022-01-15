select 
    sum(Attachment.[TotalPrice(UAH)]) as [Price],
    sum(Rent.Deposit)
    from Rent
        left join Attachment on Attachment.rent_id = Rent.rent_id
    group by Rent.order_id
    having Rent.order_id = 1;