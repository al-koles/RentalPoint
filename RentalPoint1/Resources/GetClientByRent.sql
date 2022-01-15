select [Order].client_id
    from [Order]
        join Rent on Rent.order_id = [Order].order_id
    where Rent.rent_id = @rent_id;