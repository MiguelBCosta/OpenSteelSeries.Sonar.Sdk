**Disclaimer:** Este projeto é desenvolvido de forma independente e não possui qualquer relação com a SteelSeries. A biblioteca OpenSteelSeries.Sonar.SDK foi criada para fornecer uma interface de comunicação com a API REST do SteelSeries Sonar, mas seu desenvolvimento é realizado de maneira não oficial e não está associado à SteelSeries.

# OpenSteelSeries.Sonar.SDK

**OpenSteelSeries.Sonar.SDK** é uma biblioteca de código aberto projetada para fornecer uma interface de comunicação com a API REST do SteelSeries Sonar. Com ela, você pode:

- [x] Alterar o modo de operação entre clássico e streamer.
- [x] Ajustar o volume de cada dispositivo.
- [x] Mutar e desmutar seu microfone.
- [x] Alterar o perfil de cada dispositivo.
- [x] Resgatar o estado de cada uma das funcionalidades acima.

**Nota:** O uso desta biblioteca pode ser afetado por atualizações no SteelSeries Sonar, e é importante estar ciente disso ao decidir implementá-la em seu projeto.

## RoadMap

**Feito:**
- [x] VolumeSettings Classic
- [x] VolumeSettings Streamer
- [x] Configs
- [x] Mode

**A fazer:**
- [ ] Redirecionamentos Classic
- [ ] Redirecionamentos Streamer
- [ ] Audio Devices
- [ ] Feature Controller
- E outras funcionalidades ainda não mapeadas

## Documentação

O projeto é separado em dois pacotes:

1. **OpenSteelSeries.Sonar.SDK**: Neste pacote, toda a interface de comunicação está implementada e pode ser utilizado individualmente. Para mais informações, leia o [README](OpenSteelSeries.Sonar.SDK/README.md).

2. **OpenSteelSeries.Sonar.SDK.DependencyInjection**: Este pacote tem como objetivo injetar as dependências e facilitar seu uso. Para mais informações, leia o [README](OpenSteelSeries.Sonar.SDK.DependencyInjection/README.md).

Certifique-se de explorar a documentação de cada pacote para entender como utilizá-los da melhor forma em seu projeto.
