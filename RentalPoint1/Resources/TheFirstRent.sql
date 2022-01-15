select min([From(date)])
    from Rent
    group by order_id
    having order_id = @order_id;