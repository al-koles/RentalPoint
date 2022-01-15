select 
    Client.client_id, 
    Client.[Discount(%)], 
    DiscountType.DiscountTypeName, 
    Client.LastName,
    Client.FirstName, 
    Client.SecondName, 
    Client.Gender, 
    Client.PhoneNumber, 
    Client.Email, 
    Client.[Address], 
    Client.PostCode, 
    Client.RegistrationDate, 
    Client.[Description] 
    from Client
        join DiscountType on DiscountType.discountType_id = Client.discountType_id
