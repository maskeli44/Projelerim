import 'package:get/get_connect/http/src/response/response.dart';
import 'package:get/get_state_manager/src/simple/get_controllers.dart';
import 'package:homemade/data/repository/popular_product_repo.dart';
import 'package:homemade/models/products_model.dart';

class RecommendedProductController extends GetxController {
  final PopularProductRepo recommendedProductRepo;
  RecommendedProductController({required this.recommendedProductRepo});
  List<dynamic> _recommendedProductList = [];
  List<dynamic> get recommendedProductList => recommendedProductList;

  bool _isLoaded = false;
  bool get isLoaded => _isLoaded;

  Future<void> getRecommendedProductList() async {
    Response response =
        await recommendedProductRepo.getRecommendedProductList();
    if (response.statusCode == 200) {
      _recommendedProductList = [];
      recommendedProductList.addAll(Product.fromJson(response.body).products);
      print(recommendedProductList);
      _isLoaded = true;
      update();
    } else {
      print("could not get products recommended");
    }
  }
}
