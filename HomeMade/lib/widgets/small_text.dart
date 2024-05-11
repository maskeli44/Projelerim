import 'package:flutter/cupertino.dart';

class  SmallText extends StatelessWidget {
  final Color? color;
  final String text;
  double size;
  double heigh;

  SmallText({Key? key, this.color = const Color(0xFF89dad0),
    required this.text,
    this.size = 20,
    this.heigh=1.2,

  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Text(
      text,

      style: TextStyle(
          fontFamily: 'Roboto',
          color: color,
          fontSize: size,
        height: heigh,

      ),

    );
  }
}
