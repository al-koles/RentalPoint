update Client set
    [Discount(%)] = @Discount,
    discountType_id = @discountType_id
    where client_id = @client_id;