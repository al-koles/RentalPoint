select 
    count(Rent.rent_id) as [RentAmount],
    Product.product_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName
    from Rent
        right join Good on Good.good_id = Rent.copy_id 
        right join Product on Good.product_id = Product.product_id
        join Model on Product.model_id = Model.model_id
        join Producer on Product.producer_id = Producer.producer_id
        join Brand on Model.brand_id = Brand.brand_id
        join ModelType on Model.modelType_id = ModelType.modelType_id
    group by 
        Product.product_id,
        ModelType.ModelTypeName,
        Producer.ProducerName,
        Brand.BrandName,
        Model.ModelName
    order by count(Rent.rent_id) desc, Product.product_id asc;