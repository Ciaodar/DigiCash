import { useEffect } from "react";
import { View, Text , SafeAreaView , Image } from "react-native";
import ShowBalance from "../../components/main/ShowBalance";
import Button from "../../components/ui/Button"
import {styles , GlobalStyles} from "../../constants/style";

function MainScene(){

    useEffect(()=>{

    })
    return(
        <SafeAreaView>
            <View style = {styles.generalView}>
            <Image source={require("../../assets/DigiCash.png")} style = {styles.digiCash}/>
        <View>          
            <Text style = {styles.container}>Balance Wallet</Text>
            <ShowBalance/>
            <Text style = {styles.paragraph}>Transfer Buton</Text>
            <Text style = {styles.paragraph}>İşlem Geçmişi</Text>
            
        </View>
        </View>
        </SafeAreaView>
    );
}


export default MainScene;