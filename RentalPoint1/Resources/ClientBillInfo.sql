select 
    Client.client_id,
    Client.LastName,
    Client.FirstName,
    Client.SecondName,
    Client.[Discount(%)] as [Discount]
    from Client
        join [Order] on [Order].client_id = Client.client_id
    where [Order].order_id = @order_id;