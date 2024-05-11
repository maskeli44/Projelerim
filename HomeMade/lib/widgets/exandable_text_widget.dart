import 'package:flutter/material.dart';
import 'package:homemade/utils/colors.dart';
import 'package:homemade/utils/dimensions.dart';
import 'package:homemade/widgets/small_text.dart';

class ExandableTextWidget extends StatefulWidget {
  final String text;

  const ExandableTextWidget({Key? key,
    required this.text}) : super(key: key);

  @override
  State<ExandableTextWidget> createState() => _ExandableTextWidgetState();
}

class _ExandableTextWidgetState extends State<ExandableTextWidget> {
  late String firstHalf;
  late String secondHalf;

  bool hiddenText = true;
  double textHeight = Dimensions.screenHeigh/5.63;
  @override
  void initState(){
    super.initState();
    if(widget.text.length>textHeight){
      firstHalf = widget.text.substring(0, textHeight.toInt());
      secondHalf = widget.text.substring(textHeight.toInt()+1,widget.text.length);
    } else{
      firstHalf=widget.text;
      secondHalf="";
    }
  }


  @override
  Widget build(BuildContext context) {
    return Container(
      child: secondHalf.isEmpty?SmallText(size: Dimensions.font16,text: firstHalf):Column(
        children: [
          SmallText(heigh: 1.8, color: AppColors.paraColor,size:Dimensions.font16,text: hiddenText?(firstHalf+"..."):(firstHalf+secondHalf)),
          InkWell(
            onTap: (){
              setState(() {
                hiddenText=!hiddenText;
              });

            },
            child: Row(
              children: [
                SmallText(text: "Show More", color: AppColors.mainColor,),
                Icon(hiddenText?Icons.arrow_drop_down:Icons.arrow_drop_up, color: AppColors.mainColor,)

              ],
            ),
          )
        ],
      ),
    );
  }
}
