import React, { useState, useEffect, useRef } from 'react';
import './gergerenfunc.css';
import { Search } from "react-bootstrap-icons";
import {Link} from 'react-router-dom';
import LoadingBar from 'react-top-loading-bar'

import funcoes from '../../Services/FuncoesGerente'

function GerGerenFunc(){

  const loadingBar = useRef(null);
  const api = new funcoes();
  const [listafunc,setListaFunc] = useState([]);

  const BuscarFuncionarios = async() =>{
    loadingBar.current.continuousStart();
    const x = await api.BuscarFuncionarios();
    setListaFunc([...x]);
    loadingBar.current.complete();
  }

  useEffect(() =>{
    BuscarFuncionarios();
  },[])

    return(
        <div className="prigerenfunc">
          <LoadingBar
          height={3}
          color='#f11946'
          ref={loadingBar}
          />
            <div className="titulo">
                <h1 id="titulogergeren">Gerenciamento de Funcionário</h1>
            </div>

            <div className="maingergerenfunc">
              <div className="divagergeren">
                  <h4>Buscar 
                    <Search size={16} style={{ cursor: "pointer" }} className="m3" onClick={BuscarFuncionarios}/>
                  </h4>
                  <a href="/menugerente">Voltar</a>
              </div>
            <div className="movimentacao">
              <div className="table">
                <thead id="colunas">
                  <tr>
                    <th>Nome</th>
                    <th>CPF</th>
                    <th>Salário</th>
                    <th>N° Carteira de Trabalho</th>
                    <th></th>
                    <th></th>
                  </tr>
                </thead>
                <tbody className="black">
                  {listafunc.map((item) =>(
                    <tr key={item.idconta} id="branco">
                      <td>{item.nome}</td>
                      <td>{item.cpf}</td>
                      <td>{item.salario}</td>
                      <td>{item.carteira}</td>
                      <td>
                          <Link to={{
                            pathname:"/informacoesfuncionario",
                            state:{infofunc:{item}}
                          }}>Ver Detalhadamente</Link>
                        </td>
                      <td>
                        <Link to={{
                          pathname:"/excluirfunc",
                          state:{infofunc:{item}}
                        }}>Demitir</Link>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </div>
            </div>
        </div>
      </div>
    )
}

export default GerGerenFunc;