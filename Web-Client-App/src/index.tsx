import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import {createStore} from 'redux';
import { Provider } from 'react-redux';
import Reducer from './Data/Reducer';
// import { syncHistoryWithStore, routerReducer } from 'react-router-redux'

import 'primereact/resources/themes/nova-light/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';

const Store = createStore(Reducer); 

ReactDOM.render(<Provider store={Store}><App /></Provider>, document.getElementById('root'));
