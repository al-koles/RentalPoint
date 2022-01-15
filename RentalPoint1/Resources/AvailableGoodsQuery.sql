select 
    Good.good_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName,
    Product.[Price(UAH/day)] - Product.[Price(UAH/day)] * Product.[Discount(%)] / 100 as [Price(UAH/day)],
    Product.[Deposit(UAH)]
    from Good
        join Product on Good.product_id = Product.product_id
        join Model on Product.model_id = Model.model_id
        join Producer on Product.producer_id = Producer.producer_id
        join Brand on Model.brand_id = Brand.brand_id
        join ModelType on Model.modelType_id = ModelType.modelType_id
    where 
    Good.Condition = 'True' and
    Good.good_id not in 
    (
        select copy_id from Rent
           join [Order] on [Order].order_id = Rent.order_id 
           where 
               Rent.ReturnDate is null and
               [Order].CancelDate is null
    );