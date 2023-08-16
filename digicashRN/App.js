import { StatusBar } from 'expo-status-bar';
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import MainScene from './Screens/Main/MainScene';
import TransferScene from './Screens/Main/TransferScene';
import AccountContextProvider from './context/accountContext';

const Stack = createNativeStackNavigator();

function MainNavigation(){
  return(
    <Stack.Navigator screenOptions={{title:'DigiCash'}}>
      <Stack.Screen name='Main' component={MainScene} options={{headerShown:false}}/>
      <Stack.Screen name='Transfer' component={TransferScene} options={{presentation:'modal'}}/>
    </Stack.Navigator>
  )
}
export default function App() {
  return (
    <>
    <StatusBar style='dark'/>
    <AccountContextProvider>
      <NavigationContainer>
        <MainNavigation/>
      </NavigationContainer>
    </AccountContextProvider>
    </>
  );
}