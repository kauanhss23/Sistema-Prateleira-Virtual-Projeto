import React, { useState } from 'react'
import './style.css'
import api from '../../Services/FuncoesFuncionario'
import { ToastContainer, toast} from "react-toastify";


export default function InserirLivro(){
    
    const API = new api();

    const [livro,setLivro] = useState();
    const [autor,setAutor] = useState();
    const [genero,setGenero] = useState();
    const [preco,setPreco] = useState();
    const [paginas,setPaginas] = useState();
    const [idiomaprimario,setIdioma] = useState();
    const [sinopse,setSinopse] = useState();
    const [publicacao,setPublicacao] = useState(new Date().toLocaleDateString());
    const [editora,setEditora] = useState();
    const [numeroserie,setNumeroserie] = useState();
    const [edicaolivro,setEdicaolivro] = useState();
    const [imagem,setImagem] = useState();
    const [arquivolivro,setArquivo] = useState();

    const SalvarLivro = async() =>{
        try{
            const modelo = await API.SalvarLivro({
                livro,
                autor,
                genero,
                preco,
                paginas,
                idiomaprimario,
                sinopse,
                publicacao,
                editora,
                numeroserie,
                edicaolivro,
                imagem,
                arquivolivro
            });
            toast("Cadastrado com sucesso");
        }
        catch(erros) {
            if(erros.response.data.motivo)
            toast.error(erros.response.data.motivo);
            else
            toast.error(erros.response.data.motivo);
        }
    }

    return(
        <div className="containertelainserir">

            <h1 className="titulopaginserir">Inserir um Novo Livro
                <svg id="red" width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-book-fill" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                    <path fill-rule="evenodd" d="M8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"/>
                </svg>
            </h1>

            <div className="formularioinserirlivro">
                <div className="container2inserirlivro">
                    <div className="entradadedados">
                        <label>Nome do Livro</label>
                        <input type="text" onChange={(e) => setLivro(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Nome do Autor</label>
                        <input type="text" onChange={(e) => setAutor(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Genero</label>
                        <input type="text" onChange={(e) => setGenero(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Preco</label>
                        <input type="number" onChange={(e) => setPreco(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Numero de Paginas</label>
                        <input type="number" onChange={(e) => setPaginas(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Idioma</label>
                        <input type="text" onChange={(e) => setIdioma(e.target.value)}></input>
                    </div>
                </div>
                <div className="container3inserirlivro">
                    <div className="entradadedados">
                        <label>Sinopse</label>
                        <textarea onChange={(e) => setSinopse(e.target.value)}></textarea>
                    </div>
                    <div className="entradadedados">
                        <label>Publicacao</label>
                        <input type="date" value={publicacao} onChange={(e) => setPublicacao(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Editora</label>
                        <input type="text" onChange={(e) => setEditora(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Numero de Serie</label>
                        <input type="text" onChange={(e) => setNumeroserie(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Edição do Livro</label>
                        <input type="text" onChange={(e) => setEdicaolivro(e.target.value)}></input>
                    </div>
                    <div className="entradadedados">
                        <label>Imagem do Livro</label>
                        <input type="file" onChange={(e) => setImagem(e.target.files[0])} ></input>
                    </div>
                    <div className="entradadedados">
                        <label>Arquivo do Livro</label>
                        <input type="file" onChange={(e) => setArquivo(e.target.files[0])} ></input>
                    </div>
                </div>
            </div>
            <div className="eventostelainserir">
                <a href="/menufuncionario" className="btn btn-dark acc">Voltar</a>
                <button className="btn btn-success acc" onClick={SalvarLivro}>Salvar</button>
            </div>
            <ToastContainer/>
        </div>
    )
}