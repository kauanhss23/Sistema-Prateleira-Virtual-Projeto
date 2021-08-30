import React from "react";
import './menucliente.css';
import {useHistory} from 'react-router-dom';

import perfilimage from './perfil-de-usuario.png'

export default function MenuCliente(props){
      const history = useHistory();
      
      console.log(props.location.state);

      const historico = async() =>{
        const item = props.location.state;
        history.push({
          pathname:"/HistCompras",
          state:item
        });
      }
      const perfil = () =>{
        const retorno = props.location.state;
        history.push({
          pathname:"/Perfil",
          state:retorno
        });
      }
      const compras = () =>{
        const retorno = props.location.state;
        history.push({
          pathname:"/fazercompra",
          state:retorno
        })
      }
    return(
    <div className="primaria">
      <div className="main">
          <div id="titulo">
              <h2 id="color">Seja Bem-Vindo</h2>
          </div>
          
          <div id="container">
            <div id="subcontainer1"></div>
            <div id="subcontainer2">
              
              <div id="acoes">
                <div>
                  <div className="btn btn-light" id="acao" onClick={historico}>Historico de Compras</div>
                </div>
                <div>
                  <div className="btn btn-light" id="acao" onClick={compras}>Fazer Compra</div>
                </div>
                <div>
                <a href="/" className="btn btn-secondary" id="acao">Sair</a>
                </div>
              </div>

            </div>
            <div id="subcontainer3">
              <button className="campoimg" onClick={perfil}>
                  <img src={perfilimage} id="img" alt="pefil"
                  ></img>
              </button>
            </div>
          </div>
        </div>
        
        <div id="rodape">
              <h3 id="color">Direitos do site reservados @CopyRight</h3>
            </div>
      </div>
    )
}
