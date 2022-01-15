select 
    Rent.rent_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName,
    Rent.[From(date)], 
    Rent.[To(date)],
    Rent.[TotalPrice(UAH)],
    Rent.[Deposit]
    from [Order]
        join Rent on Rent.order_id = [Order].order_id
        join Good on Rent.copy_id = Good.good_id
        join Product on Good.product_id = Product.product_id
        join Model on Product.model_id = Model.model_id
        join Producer on Product.producer_id = Producer.producer_id
        join Brand on Model.brand_id = Brand.brand_id
        join ModelType on Model.modelType_id = ModelType.modelType_id
    where 
        [Order].client_id = @client_id and
        [Order].CancelDate is null and
        Rent.ReturnDate is null;