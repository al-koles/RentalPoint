select Product.[Price(UAH/day)]
    from Product
        join Good on Good.product_id = Product.product_id
    where Good.good_id = @good_id;