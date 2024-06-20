# TechStoreAPI
This is a RESTful API for retrieving product information from all the products in [TechStore](https://github.com/MartinKulev/TechStore). The API provides endpoints to fetch all products or a specific product based on its ID.

# Endpoints
## 1. Retrieve All Products
This endpoint retrieves all products from the database.

### Request:
```bash
$ curl https://techstoreapi.azurewebsites.net/Tech/GetAllProducts
```

### Response example:
```json
[
    {
        "ProductID": 1,
        "CategoryName": "Smartphones",
        "ImageURL": "https://s13emagst.akamaized.net/products/53851/53850763/images/res_93715477679e68a31b22bc10a3c2ccd9.png?width=720&height=720&hash=FB20A79F68EFB629A99C8A9FE569A093",
        "Description": "Смартфон Samsung Galaxy A54, 256GB, 8GB RAM, 5G, Awesome Lime",
        "Brand": "Samsung Galaxy",
        "Model": "A54",
        "Price": 696.54,
        "IsInPromotion": false,
        "NewPrice": 0,
        "IsDisabled": false
    },
    {
        "ProductID": 2,
        "CategoryName": "Smartphones",
        "ImageURL": "https://s13emagst.akamaized.net/products/56345/56344987/images/res_e03fd3f8905542868387f240e70f2b8f.jpg?width=720&height=720&hash=230A67285BC51D094AA7B82C1D5D91DC",
        "Description": "Смартфон Xiaomi Redmi Note 12S, 8GB RAM, 256GB, Onyx Black",
        "Brand": "Xiaomi",
        "Model": "Redmi Note 12S",
        "Price": 355.52,
        "IsInPromotion": false,
        "NewPrice": 0,
        "IsDisabled": false
    },
    {
        "ProductID": 3,
        "CategoryName": "Smartphones",
        "ImageURL": "https://s13emagst.akamaized.net/products/59710/59709656/images/res_5dd3eb51a30d177518db7f87070f97a4.jpg?width=720&height=720&hash=16E824ABDC9CB12A8B5D0E3F41AF5343",
        "Description": "Смартфон Xiaomi Redmi 12, 8GB RAM, 256GB, Midnight Black",
        "Brand": "Xiaomi",
        "Model": "Redmi 12",
        "Price": 279.41,
        "IsInPromotion": false,
        "NewPrice": 0,
        "IsDisabled": false
    }
]
```

## 2. Retrieve Product by ID
This endpoint retrieves information about a specific product based on its ID.

### Request:
```bash
$ curl https://localhost:7188/Tech/GetProduct/{productID}
```

### Response example:
```json
{
    "ProductID": 1,
    "CategoryName": "Smartphones",
    "ImageURL": "https://s13emagst.akamaized.net/products/53851/53850763/images/res_93715477679e68a31b22bc10a3c2ccd9.png?width=720&height=720&hash=FB20A79F68EFB629A99C8A9FE569A093",
    "Description": "Смартфон Samsung Galaxy A54, 256GB, 8GB RAM, 5G, Awesome Lime",
    "Brand": "Samsung Galaxy",
    "Model": "A54",
    "Price": 696.54,
    "IsInPromotion": false,
    "NewPrice": 0,
    "IsDisabled": false
}
```

# Usage
To use the API, simply send HTTP GET requests to the endpoints.
