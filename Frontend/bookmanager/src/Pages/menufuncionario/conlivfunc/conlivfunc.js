import React, { useRef, useEffect } from 'react';

import {useState} from 'react'
import './conlivfunc.css';
import {Link} from 'react-router-dom';
import { Search } from "react-bootstrap-icons";
import LoadingBar from 'react-top-loading-bar'

import api from '../../Services/FuncoesFuncionario'

export default function ConsultarLivroFunc(){
    
    const loadingBar = useRef(null);
    const funcoes = new api();
    const [livros,setLivros] = useState([]);

    const Buscarlivros = async () =>{
        loadingBar.current.continuousStart();
        const x = await funcoes.ConsultarLivros();
        setLivros([...x]);
        loadingBar.current.complete();
    }
    useEffect(() => {
        Buscarlivros();
      }, []);

    return(
        <body className="corpo">
            <LoadingBar
            color='red'
            height={5}
            ref={loadingBar}
            />

            <div className="corpotabela">
                <div id="tituloconsultarlivro">
                    <h2 id="subtituloconsultarlivro">Consultar Livros</h2>
                    <Search size={26} style={{ cursor: "pointer" }} onClick={Buscarlivros}/>
                </div>
                <div className="compactador">
                    <div id="filtrostb">
                        <div className="voltartelaconsult">
                            <a href="/menufuncionario" className="btn btn-secondary">Voltar Ao Menu</a>
                        </div>
                    </div>
                    <div id="controladormodelotb">
                        <div id="modelotabela">
                            <div className="table">
                                <thead className="orange">
                                    <tr>
                                        <th>Nome Do Livro</th>
                                        <th>Autor</th>
                                        <th>Genero</th>
                                        <th>Data de Publicação</th>
                                        <th>Preco</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody className="black">
                                    {livros.map(e =>(
                                        <tr id="branco">
                                            <td>{e.livro}</td>
                                            <td>{e.autor}</td>
                                            <td>{e.genero}</td>
                                            <td>{new Date(e.publicacao).toLocaleDateString()}</td>
                                            <td>{e.preco}</td>
                                            <td>
                                            <Link to={{
                                                pathname:"/alterlivfunc",
                                                state:e
                                            }}>
                                                Alterar
                                            </Link>
                                            </td>
                                        </tr>
                                    ))}
                                </tbody>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="ultimo">
                    <h3 className="preto">Consulte e Altere livros por aqui</h3>
                </div>
            </div>

        </body>
    );
}

