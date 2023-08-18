import { useEffect } from "react";
import { View, Text } from "react-native";
import ShowBalance from "../../components/main/ShowBalance";

function MainScene(){

    useEffect(()=>{

    })
    return(
        <View>
            <Text>balance-wallet</Text>
            <ShowBalance/>
            <Text>Transfer buton</Text>
            <Text>İşlem geçmişi</Text>
        </View>
    );
}

export default MainScene;