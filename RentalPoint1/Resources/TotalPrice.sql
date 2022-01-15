select 
    sum(Rent.[TotalPrice(UAH)]) as [RentsPrice],
    sum(Attachment.[TotalPrice(UAH)]) as [AttachmentsPrice],
    sum(Rent.Deposit)
    from Rent
        left join Attachment on Attachment.rent_id = Rent.rent_id
    group by Rent.order_id
    having Rent.order_id = @order_id;