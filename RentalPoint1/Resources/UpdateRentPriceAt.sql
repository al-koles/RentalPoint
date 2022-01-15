update Rent set 
    Rent.[TotalPrice(UAH)] = (
        select DATEDIFF(day, Rent.[From(date)], Rent.[To(date)]) * (Product.[Price(UAH/day)] - Product.[Price(UAH/day)] * Product.[Discount(%)] / 100)
            from Rent 
                join Good on Rent.copy_id = Good.good_id
                join Product on Product.product_id = Good.product_id
            where Rent.rent_id = @id
    )
    where rent_id = @id