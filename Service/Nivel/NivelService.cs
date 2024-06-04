using Reciicer.Repository.Interface;

namespace Reciicer.Service.Nivel
{
    public class NivelService
    {
        private readonly INivelRepository _nivelRepository;

        public NivelService(INivelRepository nivelRepository)
        {
            _nivelRepository = nivelRepository;
        }

        public IEnumerable<Models.Entities.Nivel> PopularSelect()
        {
            return _nivelRepository.ListarNivel();
        } 
    }
}