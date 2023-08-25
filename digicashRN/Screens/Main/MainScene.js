import { useEffect } from "react";
import { View, Text , SafeAreaView , Image } from "react-native";
import ShowBalance from "../../components/main/ShowBalance";
import Button from "../../components/ui/Button"
import {styles , GlobalStyles} from "../../constants/style";
import HistoryScreen from "./HistoryScreen";

function MainScene(){

    useEffect(()=>{

    })
    return(
        <SafeAreaView>
            <View style = {styles.generalView}>
            <Image source={require("../../assets/DigiCash.png")} style = { {alignItems : 'center', marginLeft: 22 }}/>
        <View>          
            <Text style = {styles.container}>Balance Wallet</Text>
            <ShowBalance/>
            <View style = {styles.container}>
                <Text><Button title = "Button"/></Text>
            </View>
            <Text style = {styles.paragraph}>Transfer Buton</Text>
            <Text style = {styles.paragraph}>İşlem Geçmişi</Text>
            
        </View>
        </View>
        </SafeAreaView>
    );
}


export default MainScene;