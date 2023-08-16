import { View, Text, StyleSheet } from "react-native";

 
 function ShowBalance({amount}){
    return (
        <View style={styles.content}>
            <View>
                <Text>Your Balance</Text>
            </View>
            <View>
                <Text>$2,898.0</Text>
            </View>
        </View>
    )
 }

 export default ShowBalance;

 const styles = StyleSheet.create({
    content:{
        flex:1,
        flexDirection:'row',
        alignItems:'center',
        backgroundColor:'green'
    },
    balanceWrapper:{
        justifyContent:'center'
    }

 })