import 'dart:developer';

import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:homemade/data/repository/popular_product_repo.dart';
import 'package:homemade/models/cart_model.dart';
import 'package:homemade/models/products_model.dart';
import 'package:homemade/utils/colors.dart';

import 'cart_controller.dart';

class PopularProductController extends GetxController {
  final PopularProductRepo popularProductRepo;
  PopularProductController({required this.popularProductRepo});
  final List<dynamic> _popularProductList = [];
  List<dynamic> get popularProductList => _popularProductList;
  late CartController _cart;

  final bool _isLoaded = false;
  bool get isLoaded => _isLoaded;
  int _inCartItem = 0;
  int get inCartItem => _inCartItem + _quantity;

  int _quantity = 0;
  int get quantity => _quantity;

  Future<void> getPopularProductList() async {
    var firebase = FirebaseFirestore.instance;

    var anindaYemek = firebase.collection('AnindaYemek');

    var data = await anindaYemek.doc('ejFRM4qYGJF2gMs28e9k').get();

    log(data.data().toString());
    List<Map> liste = data.data()!['Ucretli'];

    log(data.data()!['Ucretli'][0]['kahvaltı'][0]['include'].toString());
    /* Response response = await popularProductRepo.getPopularProductList();
    if (response.statusCode == 200) {
      print(response.body);
      _popularProductList = [];
      _popularProductList
          .addAll(Product.fromJson(json.decode(response.body)).products);
      //print(_popularProductList);
      _isLoaded = true;
      update();
    } else {}*/
  }

  void setQuantity(bool isIncrement) {
    if (isIncrement) {
      _quantity = checkQuantity(_quantity + 1);
      print("number of items" + _quantity.toString());
    } else {
      _quantity == checkQuantity(_quantity - 1);
      //  print("decrement" +_quantity.toString());
    }
    update();
  }

  int checkQuantity(int quantity) {
    if ((_inCartItem + quantity) < 0) {
      Get.snackbar(
        "Item count",
        "You can't reduce more!",
        backgroundColor: AppColors.mainColor,
        colorText: Colors.white,
      );
      if (_inCartItem > 0) {
        _quantity = -_inCartItem;
        return _quantity;
      }
      return 0;
    } else if ((_inCartItem + quantity) > 20) {
      Get.snackbar(
        "Item count",
        "You can't reduce more!",
        backgroundColor: AppColors.mainColor,
        colorText: Colors.white,
      );
      return 20;
    } else {
      return quantity;
    }
  }

  void initDataProduct(ProductModel product, CartController cart) {
    _quantity = 0;
    _inCartItem = 0;
    _cart = cart;
    var exist = false;
    exist = _cart.existInCart(product);

    //if exist
    //get from storage _inCardItems=3
    //  print("exist or not" + exist.toString());
    if (exist) {
      _inCartItem = _cart.getQuantity(product);
    }
    // print("the quantity in the cart is" + _inCartItem.toString());
  }

  void addItem(ProductModel product) {
    _cart.addItem(product, quantity);
    _quantity = 0;
    _inCartItem = _cart.getQuantity(product);
    _cart.items.forEach((key, value) {
      print("the id is " +
          value.id.toString() +
          "the quantity is" +
          value.quantity.toString());
    });

    update();
  }

  int get totalItems {
    return _cart.totalItems;
  }

  List<CartModel> get getItems {
    return _cart.getItems;
  }
}
