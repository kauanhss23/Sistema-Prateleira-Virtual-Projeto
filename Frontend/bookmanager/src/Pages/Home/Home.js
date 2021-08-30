import React, {useRef} from 'react'
import { useState } from 'react';
import './Home.css'
import {useHistory} from 'react-router-dom'
import LoadingBar from 'react-top-loading-bar'
import Services from '../Services/SistemaPrateleira'

import { ToastContainer, toast} from "react-toastify";
import 'react-toastify/dist/ReactToastify.css';

export default function Home(){

    const api = new Services();
    const history = useHistory();
    const loadingBar = useRef(null);
    const [email,setEmail] = useState('');
    const [senha,setSenha] = useState('');

    const Logar = async() => {

        try{
        loadingBar.current.continuousStart();
        const x = await api.Logar({
            email:email,
            senha:senha
        });
        
        loadingBar.current.complete();
        if (x.perfil === "cliente")
        history.push({
            pathname: '/menucliente',
            state:x
          });
        else if(x.perfil === "funcionario")
        history.push({
            pathname: '/menufuncionario',
            state: x
          });
        
        else if(x.perfil === "gerente")
        history.push({
            pathname: '/menugerente',
            state:x
          });
        }
        catch(error)
        {
            if(error.response.data.motivo)
            toast.error("😵 " + error.response.data.motivo);
            else
            toast.error("😔 Tente Novamente mais tarde")
        }
    }

    const criarconta = () =>{
        history.push({
            pathname:"/criarconta"
        })
    }

    return (
        <body className="white">
            
            <LoadingBar
                height={4}
                color='#f11946'
                ref={loadingBar}
            />

            <div className="telainicial">

                <div className="container7">
                        <h5>Entrar:</h5>
                        <input type="text" onChange={(e) => setEmail(e.target.value)} required placeholder="Email"></input>
                        
                        <input type="password" onChange={(e) => setSenha(e.target.value)} required placeholder="Senha"></input>

                    <div className="acao">
                        <button onClick={Logar}>Logar</button>
                    </div>
                    <div className="acao2">
                        <button onClick={criarconta}>Criar conta</button>
                    </div>
                </div>

            </div>
            <ToastContainer />
        </body>
    );
}