select 
    Good.good_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName,
    Product.[Price(UAH/day)],
    Product.[Deposit(UAH)],
    Rent.[From(date)],
    Rent.[To(date)],
    Rent.[TotalPrice(UAH)] as [Price]
    from Rent
        join Good on Good.good_id = Rent.copy_id 
        join Product on Good.product_id = Product.product_id
        join Model on Product.model_id = Model.model_id
        join Producer on Product.producer_id = Producer.producer_id
        join Brand on Model.brand_id = Brand.brand_id
        join ModelType on Model.modelType_id = ModelType.modelType_id
    where rent.order_id = @order_id;