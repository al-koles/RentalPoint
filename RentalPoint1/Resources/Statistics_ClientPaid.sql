select
    sum(Rent.[TotalPrice(UAH)]) + sum(Attachment.[TotalPrice(UAH)]) as [Paid Price],
    sum(Rent.Penalty) as [Total Penalty],
    Client.client_id,
    Client.FirstName,
    Client.LastName,
    Client.SecondName
    from Client
        left join [Order] on [Order].client_id = Client.client_id
        left join Rent on Rent.order_id = [Order].order_id
        left join Attachment on Attachment.rent_id = Rent.rent_id
    where
        [Order].CancelDate is null
    group by
        Client.client_id,
        Client.FirstName,
        Client.LastName,
        Client.SecondName
    order by [Paid Price] desc, [Total Penalty] asc, Client.client_id asc;

    --Заказ не был отменен и 