select
    COUNT(Rent.rent_id) as [Rent amount],
    Client.client_id,
    Client.FirstName,
    Client.LastName,
    Client.SecondName
    from Client
        left join [Order] on [Order].client_id = Client.client_id
        left join Rent on Rent.order_id = [Order].order_id
    group by
        Client.client_id,
        Client.FirstName,
        Client.LastName,
        Client.SecondName
    order by [Rent amount] desc, Client.client_id asc;