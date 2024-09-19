using maritimoSampa.Models;
using Microsoft.AspNetCore.Mvc;

namespace maritimoSampa.Controllers
{
    public class SampaController : Controller
    {
        public IActionResult Santos()
        {
            var santos = new List<Municipio>
            {
                new Municipio
                {
                nome = "Santos",
                regiao = "Sul",
                populacao = 418.608,
                desc = "Santos é uma cidade fundamental no cenário econômico " +
                "não apenas de São Paulo, mas de todo o Brasil. Sua importância decorre principalmente do Porto de Santos, " +
                "o maior da América Latina. A cidade é um ponto crucial para importação e exportação, movimentando uma vasta " +
                "gama de produtos, desde commodities agrícolas até produtos manufaturados. Sua localização estratégica e " +
                "infraestrutura portuária de alto nível tornam-na um hub vital para o comércio internacional, " +
                "influenciando diretamente a economia do país.",
                Historia = new List<Historia>{
                new Historia
                {
                resumoHistorico = "A cidade de Santos tornou-se destaque nessas áreas pelos seguintes fatores: Localização Estratégica; " +
                "Infraestrutura Portuária; Capacidade de Movimentação; Tecnologia e Logística; Política e Investimentos; " +
                "Diversificação de Atividades"
                }
                },

                Produto = new List<Produto>{
                new Produto
                {
                nome = "Soja",
                categoria = "Produto Agrícola",
                descp = "A soja é essencialmente uma espécie autógama, ou seja, uma planta polinizada por ela mesma e não " +
                "por outras plantas, mesmo que vizinhas a ela, com flores perfeitas e órgãos masculinos e femininos protegidos " +
                "dentro da corola"
                }
                },
            }
            };

            ViewBag.nome = santos[0].nome;
            return View(santos);

        }
        public IActionResult Guaruja()
        {
            var guaruja = new List<Municipio>
            {
            new Municipio
            {
                nome = "Guarujá",
                regiao = "Sul",
                populacao = 322.750,
                desc = "Guarujá, localizado no litoral do estado de São Paulo, tem uma significativa influência na economia de " +
            "exportação e importação do Brasil, principalmente devido à sua proximidade com o Porto de Santos, o maior porto " +
            "da América Latina. Em resumo, Guarujá, através do Porto de ',\r\n     descInicial2: 'Santos, desempenha um " +
            "papel vital na economia de exportação e importação do Brasil, contribuindo significativamente para o comércio " +
            "internacional, geração de empregos e desenvolvimento econômico regional.",
            Historia = new List<Historia>{
                new Historia
                {
                resumoHistorico = "Guarujá tornou-se um destaque no cenário de exportação e importação principalmente devido ao " +
                "desenvolvimento e à modernização do Porto de Santos, que é uma infraestrutura fundamental para a logística e o " +
                "comércio exterior do Brasil.São Sebastião tornou-se um destaque no quesito exportação principalmente devido ao " +
                "desenvolvimento estratégico do Terminal Marítimo Almirante Barroso (TEBAR), operado pela Transpetro, uma " +
                "subsidiária da Petrobras."
                }
                },

                Produto = new List<Produto>{
                new Produto
                {
                nome = "Café",
                categoria = "Produto Agrícola",
                descp = "O café é uma das bebidas mais apreciadas em todo o planeta e é produzido dos grãos de café, a semente " +
                "do fruto do cafeeiro. O cafeeiro é uma espécie originária da Etiópia que se difundiu por todo o mundo."
                }
                },
            }
            };
            ViewBag.nome = guaruja[0].nome;
            return View(guaruja);
        }
        public IActionResult SaoSebastiao()
        {
            var ssebastiao = new List<Municipio>
            {
            new Municipio
            {
                nome = "São Sebastião",
                regiao = "Norte",
                populacao = 90.328,
                desc = "São Sebastião, através do seu porto, tem uma influência significativa na economia de exportação e " +
            "importação do Brasil, especialmente no setor de petróleo e produtos químicos. Embora não tão grande quanto o " +
            "Porto de Santos, o Porto de São ,Sebastião desempenha um papel crucial em certos segmentos, contribuindo para " +
            "a economia regional e nacional por meio da geração de empregos, arrecadação de receitas e apoio à " +
            "infraestrutura local.",
            Historia = new List<Historia>{
                new Historia
                {
                resumoHistorico = "São Sebastião tornou-se um destaque no quesito exportação principalmente devido ao " +
                "desenvolvimento estratégico do Terminal Marítimo Almirante Barroso (TEBAR), operado pela Transpetro, uma " +
                "subsidiária da Petrobras."
                }
                },

                Produto = new List<Produto>{
                new Produto
                {
                nome = "Petróleo",
                categoria = "Recurso Fóssil",
                descp = "O petróleo é um líquido natural, inflamável, oleoso, de cheiro característico e com densidade menor " +
                "que a da água. É uma mistura complexa de hidrocarbonetos, ou seja, de substâncias formadas apenas por " +
                "hidrogênio e carbono."
                }
                },
            }
            };
            ViewBag.nome = ssebastiao[0].nome;
            return View(ssebastiao);
        }
        public IActionResult Itanhaem()
        {
            var itanhaem = new List<Municipio>
            {
            new Municipio
            {
                nome = "Itanhaém",
                regiao = "Sul",
                populacao = 103.102,
                desc = "Itanhaém, apesar de não ser um grande centro de exportação e importação, tem uma influência indireta na " +
            "economia regional graças à sua proximidade com o Porto de Santos e ao turismo local. A cidade pode explorar " +
            "oportunidades para desenvolver sua ,infraestrutura logística e comercial, potencialmente aumentando sua " +
            "participação no comércio exterior. Contudo, a falta de um porto comercial próprio limita a influência direta " +
            "de Itanhaém na economia de exportação e importação do Brasil.",
            Historia = new List<Historia>{
                new Historia
                {
                resumoHistorico = "Itanhaém, embora não seja um grande centro de importação e exportação como Santos ou São " +
                "Sebastião, tem se destacado de maneira mais indireta no cenário econômico regional."
                }
                },

                Produto = new List<Produto>{
                new Produto
                {
                nome = "Pescados e Produtos Agrícolas",
                categoria = "Produto Agrícola e Pesqueiro",
                descp = "Produtos agrícolas são alimentos e commodities cultivados na agricultura, como grãos, frutas, legumes " +
                "e verduras, enquanto os pescados são alimentos obtidos da pesca, incluindo peixes, crustáceos e moluscos."
                }
                },
            }
            };
            ViewBag.nome = itanhaem[0].nome;
            return View(itanhaem);

    }   }
}
